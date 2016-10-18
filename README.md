ODocxMerge
==========

[![Build Status](https://travis-ci.org/Ventto/odocxmerge.svg?branch=master)](https://travis-ci.org/Ventto/odocxmerge)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat)](https://github.com/Ventto/odocxmerge/blob/master/LICENSE)
[![Status](https://img.shields.io/badge/status-experimental-orange.svg?style=flat)](https://github.com/Ventto/odocxmerge/)


*ODocxMerge is a simple tool using Open-XML-SDK and Mono to merge two docx files
into one.*

Requirements
------------

*mono* - Free implementation of the .NET platform including runtime and compiler


### Ubuntu

* [Update mono package repository](http://www.mono-project.com/docs/getting-started/install/linux/)

* Install packages:

```
$ apt-get install mono-devel mono-mcs
```

### Arch

```
$ pacman -S mono
```

Modules
-------

[Open-XML-SDK](https://github.com/OfficeDev/Open-XML-SDK) - Open-source libraries for working with Open XML Documents

Installation
------------

```
$ git clone --recursive https://github.com/Ventto/odocxmerge.git
$ cd odocxmerge
$ make
```

Usage
-----

```
$ ./odocxmerge.exe file1.docx file2.docx out.docx
```

Issues
------

- [ ] A previous out.docx file cannot be merged as file1 with another file
- [ ] Merging a document with a title page like document as file2 does not work well
