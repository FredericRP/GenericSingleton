# Singleton Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

**For 1.2.2 release and previous ones, this is a copy/paste from FredericRP's Standard Assets changelog, filtered for this sub package (that's why some version have no content here).**

## Unreleased

## [1.3.3] - 2023-12-03

### Fixed
- Typo in a debug log

### Changed
- Made OnAwake async if needed
- Override references to get none on the assembly definition by default

## [1.3.2] - 2022-04-06

### Fixed
- Auto dependencies in package

## [1.3.1] - 2021-10-13

### Added
- new SimpleSingleton class that does not inherit from MonoBehaviour

### Changed
- meta files due to Unity migration, synchronized with other assets

## [1.3.0] - 2021-09-15

### Changed
- This asset has now its own repository
- The namespace to GenericSingleton
- Do not use GUIDs for assembly references to make it clearer if an assembly is not found

### Fixed
- Singleton: removed the server tag in package.json to comply with unity package manifest standard
- Singleton: Debug messages are enabled only when UNITY_EDITOR and DEBUG are defined

## [1.2.2] - 2021-07-30

## [1.2.1] - 2020-07-30

### Added
- NEW: Installation guidelines for both package and submodule.

### Changed
- MOD: make package manager compatible

### Fixed
- FIX: changelog meta files
- FIX: correct MIT license for every package
- FIX: readme file with updated Documentation folder

## [1.2.0] - 2019-11-19

### Changed
- MOD: updated readme files for each plugin
- MOD: updated readme file for full instructions

## [1.1.0] - 2019-10-27

## [1.0.1] - 2019-10-16

### Added
- NEW: github social preview

### Changed
- MOD: all previous readme.txt changed to markdown format

### Removed
- DEL: removed first package export

## [1.0.0] - 2019-08-08

### Added
- first public release: a generic event handler to trigger and subscribe game events in your game in a minute.

### Changed

### Deprecated

### Removed

### Fixed

### Security
