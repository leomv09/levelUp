@echo off
set RootCA_Name=LevelUp Root CA
set Server_Name=localhost
::set Client_Name=
::set Client_Email=
set Organization=ITCR
set Organizational_Unit=IC
set Locality=Cartago
set State=Cartago
set Country=CR

@echo Creating certificate for the Root CA.
makecert -pe -n "CN=%RootCA_Name%, O=%Organization%, OU=%Organizational_Unit%, L=%Locality%, S=%State%, C=%Country%" -ss my -sr LocalMachine -a sha1 -sky signature -r "%RootCA_Name%.cer"

@echo Exporting the certificate to the repository "Personal" of "Trusted Root Certification Authorities".
certmgr -add -all -c "%RootCA_Name%.cer" -s -r LocalMachine Root

@echo Creating certificate for the web server.
makecert -pe -n "CN=%Server_Name%, O=%Organization%, OU=%Organizational_Unit%, L=%Locality%, S=%State%, C=%Country%" -ss my -sr LocalMachine -a sha1 -sky exchange -eku 1.3.6.1.5.5.7.3.1 -in "%RootCA_Name%" -is MY -ir LocalMachine -sp "Microsoft RSA SChannel Cryptographic Provider" -sy 12 "%Server_Name%.cer"

::@echo Creating certificate for the client.
::makecert -pe -n "CN=%Client_Name%, E=%Client_Email%, O=%Organization%, OU=%Organizational_Unit%, L=%Locality%, S=%State%, C=%Country%" -ss my -sr CurrentUser -a sha1 -sky exchange -eku 1.3.6.1.5.5.7.3.2 -in "%RootCA_Name%" -is Root -ir LocalMachine -sp "Microsoft RSA SChannel Cryptographic Provider" -sy 12 -# 25000000 "%Client_Name%.cer"