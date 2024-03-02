

CREATE TABLE tbl_device(
   id int PRIMARY KEY IDENTITY(1,1),
   deviceName varchar(50),
   wattage varchar(10),
   lifetime_ int,
   recentUse int,
   OptTime Datetime,
   OptChargeTime datetime)


CREATE PROCEDURE [dbo].[appendDevice] @givenDeviceName varchar(50), @givenBattery varchar(10), @givenlifetime int
AS
INSERT INTO tbl_device(deviceName,wattage,lifetime_)
VALUES(@givenDeviceName,@givenBattery,@givenlifetime)

CREATE PROCEDURE [dbo].[deviceInput] @deviceName varchar(50), @givenWattage varchar(10), @givenLifetime int
AS 
INSERT INTO tbl_devices(deviceName,wattage,lifetime_)
VALUES(@deviceName,@givenWattage,@givenLifetime)

CREATE PROCEDURE [dbo].[readingData]
AS
SELECT * FROM tbl_devices
