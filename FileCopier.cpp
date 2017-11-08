#include "stdafx.h"
#include <string>
#include <iterator>
#include <windows.h>


using namespace std;
class FileCopier
{
	static wstring s2ws(const std::string& s)
	{
		int len;
		int slength = (int)s.length() + 1;
		len = MultiByteToWideChar(CP_ACP, 0, s.c_str(), slength, 0, 0);
		wchar_t* buf = new wchar_t[len];
		MultiByteToWideChar(CP_ACP, 0, s.c_str(), slength, buf, len);
		std::wstring r(buf);
		delete[] buf;
		return r;
	}

public:
	static bool copy_file(const char* from, const char* to)
	{
		wstring fromWS = s2ws(from);
		LPCWSTR fromLP = fromWS.c_str();

		wstring toWS = s2ws(to);
		LPCWSTR toLP = toWS.c_str();

		return CopyFile(fromLP, toLP, FALSE);
		
	}

};

