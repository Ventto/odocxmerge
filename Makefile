SRC = src/odocxmerge.cs
EXE = $(notdir $(SRC:.cs=.exe))

OPENXML_SUBDIR		= lib/Open-XML-SDK
OPENXML_DLLNAME		= OpenXMLLib.dll
OPENXML_DLLBUILD	= $(OPENXML_SUBDIR)/build/OpenXmlSdkLib/$(OPENXML_DLLNAME)
OPENXML_DLL		= $(OPENXML_DLLNAME)

.PHONY: all
all:	$(EXE)

$(EXE):	$(SRC) $(OPENXML_DLL)
	mcs -r:WindowsBase.dll,$(OPENXML_DLL) $(SRC) -out:$(EXE)

$(SRC): ;

$(OPENXML_DLL):
		$(MAKE) -C $(OPENXML_SUBDIR) -f Makefile-Linux-Mono
		cp $(OPENXML_DLLBUILD) $(OPENXML_DLL)

.PHONY: clean
clean:
	$(RM) $(EXE) $(OPENXML_DLL)

