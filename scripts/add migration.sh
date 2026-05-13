#!/bin/bash
# param 1 is database context
migr_name="migr_$(date +'%Y%m%d_%H%M%S')"
cd ../mgr_1_2_TI
dotnet ef migrations add $migr_name --context $1
cd ../scripts
