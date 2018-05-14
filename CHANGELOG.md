# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [vNext]

- Updated plugin to support [Azure CLI 2.0.32](https://docs.microsoft.com/en-us/cli/azure/release-notes-azure-cli?view=azure-cli-latest#may-7-2018)
- Added: `az acr build` task..
- Added: `azure acr build-task` tasks.
- Added: `azure ams` tasks.
- Added: `azure consumption budget` tasks.
- Added: Parameters in `az cosmosdb` to specify virtual network settings.
- Added: `az dms` tasks.
- Added: `az redis patch-schedule show`.
- Added: `az redis import`.
- Added: `socket-timeout` parameter to various `az storage` tasks.
- Added: Parameters for disk caching and write accelerator to various `az vm` tasks.
- Added: `vmss perform-maintenance` task.
- Added: `eviciton-policy` parameter to `az vmss create` task.
- Added: Parameter for multi container configuration.
- BREAKING CHANGE: The parameter `Name` in `az functionapp config hostname list` was renamed to `WebappName`.
- BREAKING CHANGE: Removed deprecated ad sp reset-credentials
- BREAKING CHANGE: Profile: Removed --msi-port and --identity-port as they are no longer used
- BREAKING CHANGE: Removed the `--ids` parameter for: 
  * `express-route auth list`
  * `express-route peering list`
  * `nic ip-config list`
  * `nsg rule list`
  * `route-filter rule list`
  * `route-table route list`
  * `traffic-manager endpoint list`
- BREAKING CHANGE: Removed `--ids` from:
  * `vm extension list`
  * `vm secret list`
  * `vm unmanaged-disk list`
  * `vmss nic list`

## [0.1.0] / 2018-05-09
- First release.

[vNext]: https://github.com/arodus/nuke-azure-cli/compare/0.1.0...HEAD
[0.1.0]: https://github.com/arodus/nuke-azure-cli/tree/0.1.0
