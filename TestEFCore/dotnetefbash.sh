#!/usr/bin/env bash

dotnet_args_list="$*"

echo "dotnet ef --project TestEFCoreDataAccess.MySQL --startup-project TestEFCoreEFToolProvisionConsole $dotnet_args_list"

dotnet ef --project TestEFCoreDataAccess.MySQL --startup-project TestEFCoreEFToolProvisionConsole $dotnet_args_list
