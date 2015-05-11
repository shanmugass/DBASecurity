# Basic Requirements for DBA and Operations Password and Vendor App
This application, Phase One, will provide the ability for users to lookup environments, accounts/username, and the associated encrypted password and copy the encrypted password value from our application to whatever they need. This is mostly for Operations that require passwords for running jobs, etc. The admin area is so that the DBA team can create/update/delete values.
Additional phases may be required to include vendor/license information and other possible items.
1.	Web application so that no one needs install anything on their desktops.  It will be available to all approved users via intranet (they will be required to be logged into vpn so that their global network id can be obtained and used for lookups.
2.	Initial phase is for environments, accounts and passwords. Additional areas for vendor / license information will be requested, but not required for the initial phase.
3.	Application will be read only for most users and read/write for DBA team for maintenance of various aspects.
4.	This will be a single-sign on application, using the logged in users Global network account to check access and level of access to the application.
5.	Access to Active directory for the application so that security groups can be used to look up the users application security settings
6.	There should be an administration area for the DBA team (access limited by the user’s presence in an Active Directory Security Group, to be created) where Admin users can update/delete/create data.
7.	A read only area for other users to be able to look up an environment (prod/uat/qa/dev), user account and the encrypted password will be shown and copy will be allowed from the area that the encrypted password appears so that the user can copy and paste it into their application where appropriate.
8.	Appropriate error trapping and messages should be displayed. This can be further developed and detailed when we are on the list and the plans are firmed up.
9.	We are using SQL Server 2014 and would like developers to use as many of the new features as would apply (i.e., using merge statements instead of insert/update/delete sp.
10.	We are using TDE (transparent data encryption at the database level).
11.	Stored procedures should be used with parameters, no dynamic sql
12.	SSL should be used for traffic over the network which will meet requirements (data will then be encrypted the entire trip and while at rest)
13.	The database will be encrypted at the database level.
