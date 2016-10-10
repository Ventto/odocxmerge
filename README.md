ODocxMerge
==========

*ODocxMerge is a simple tool using Open-XML-SDK and Mono to merge two docx files
into one.*

**Warning: This tool is experimental.**

Requirements
------------

*mono* - Free implementation of the .NET platform including runtime and compiler

Modules
-------

Open-XML-SDK - Open-source libraries for working with Open XML Documents (

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
