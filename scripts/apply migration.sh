#!bin/bash
# parameter 1 is database context
cd ../mgr_1_2_TI
dotnet ef database update --context $1
cd ../scripts
