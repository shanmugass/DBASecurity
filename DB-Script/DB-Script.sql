GO

CREATE PROCEDURE getEnvironments
AS
BEGIN
	SELECT EnvId, Environment FROM environment
END

GO

CREATE PROCEDURE getAccountsInEnv
	@EnvId INT
	,@AccountName VARCHAR(100) = ''
AS
BEGIN
	SELECT a.AccountId
		, a.AccountName
		, ISNULL(a.AccountComment, '') AS AccountComment
		, ISNULL(a.AccountPwdEncrypted, '') AS AccountPwdEncrypted
		, ISNULL(a.AccountPwdEncryptKey, '') AS AccountPwdEncryptKey
		, ISNULL(a.AccountPwdEncryptionTypeID, 0) AS AccountPwdEncryptionTypeID
		, ISNULL(aet.AccountEncryptionTypeName, '') AS AccountEncryptionTypeName
		, ISNULL(a.AccountApplication, '') AS AccountApplication
	FROM Account a
		JOIN DatabaseNode d
			ON a.DatabaseId = d.DatabaseId
		JOIN Environment e
			ON d.EnvId = e.EnvId
		LEFT JOIN AccountEncryptionType aet
			ON a.AccountPwdEncryptionTypeID = aet.AccountEncryptionTypeID
	WHERE e.EnvId = @EnvId
		AND (@AccountName = '' OR a.AccountName LIKE ('%' + @AccountName + '%')) 
END

GO

