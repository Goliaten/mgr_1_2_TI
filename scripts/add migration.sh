#!/bin/bash

migr_name="migr_$(date +'%Y%m%d_%H%M%S')"
cd ../mgr_1_2_TI
dotnet ef migrations add $migr_name
cd ../scripts