# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)

## [vNext]

## [0.3.1] / 2018-06-05
- Changed supported version to [Azure CLI 2.0.33](https://docs.microsoft.com/en-us/cli/azure/release-notes-azure-cli?view=azure-cli-latest#may-22-2018)
- Changed the following `db` and `dw` properties to be read-only:
	- `requestedServiceObjectiveName`.  To update, use the `--service-objective` parameter or set the `sku.name` property.
    - `edition`. To update, use the `--edition` parameter or set the `sku.tier` property.
    - `elasticPoolName`. To update, use the `--elastic-pool` parameter or set the `elasticPoolId` property.
- Changed the following `elastic-pool` properties to be read-only:
    - `edition`. To update, use the `--edition` parameter.
    - `dtu`. To update, use the `--capacity` parameter.
    -  `databaseDtuMin`. To update, use the `--db-min-capacity` parameter.
    -  `databaseDtuMax`. To update, use the `--db-max-capacity` parameter.
- Removed `--write-accelerator` from `vm create`. The same support can be accessed through `vm update` or `vm disk attach`.
- Added new Dev-Spaces commands `aks use-dev-spaces` and `aks remove-dev-spaces`.
- Added support for exporting a container group in yaml format.
- Added support for using a yaml file to create / update a container group.
- Added `--family` and `--capacity` parameters to `db`, `dw`, and `elastic-pool` commands.
- Added table formatters to `db`, `dw`, and `elastic-pool` commands.
- Added `--boot-diagnostics-storage` to `vm create` to capture boot log
- Added `--license-type` to `[vm|vmss] update`.
- Fixed typo in help message.
## [0.2.1] / 2018-05-14
- Changed supported version to [Azure CLI 2.0.32](https://docs.microsoft.com/en-us/cli/azure/release-notes-azure-cli?view=azure-cli-latest#may-7-2018)
- Changed the parameter `Name` in `az functionapp config hostname list` was renamed to `WebappName`.
- Removed deprecated ad sp reset-credentials.
- Removed --msi-port and --identity-port in profile as they are no longer used.
- Removed the `--ids` parameter for: 
  - `express-route auth list`
  - `express-route peering list`
  - `nic ip-config list`
  - `nsg rule list`
  - `route-filter rule list`
  - `route-table route list`
  - `traffic-manager endpoint list`
- Removed `--ids` from:
  - `vm extension list`
  - `vm secret list`
  - `vm unmanaged-disk list`
  - `vmss nic list`
- Added `az acr build` task.
- Added `azure acr build-task` tasks.
- Added `azure ams` tasks.
- Added `azure consumption budget` tasks.
- Added parameters in `az cosmosdb` to specify virtual network settings.
- Added `az dms` tasks.
- Added `az redis patch-schedule show`.
- Added `az redis import`.
- Added `socket-timeout` parameter to various `az storage` tasks.
- Added parameters for disk caching and write accelerator to various `az vm` tasks.
- Added `vmss perform-maintenance` task.
- Added `eviciton-policy` parameter to `az vmss create` task.
- Added parameters for multi container configuration.

## [0.1.0] / 2018-05-09
- First release.

[vNext]: https://github.com/nuke-build/azure/compare/0.3.1...HEAD
[0.3.1]: https://github.com/nuke-build/azure/compare/0.2.1...0.3.1
[0.2.1]: https://github.com/nuke-build/azure/compare/0.1.0...0.2.1
[0.1.0]: https://github.com/nuke-build/azure/tree/0.1.0
