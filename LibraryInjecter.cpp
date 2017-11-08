#include "stdafx.h"
#include "FilesManager.cpp"
#include <vector>
#include <iterator>

#include <istream>
#include <iostream>
#include <fstream>
#include <windows.h>

using namespace std;

int main(int argc, char* argv[])
{

	//"C:\\search here\\entries"
	//"C:\\search here\\generalremotelib-release.aar"
	string folder_path = argv[1];
	string file_path = argv[2];
	int start = file_path.find_last_of("\\") + 1;
	int range = file_path.find_last_of(".") - start;
	string libName = file_path.substr(start, range);


	FilesManager filesManager = FilesManager(file_path, libName);
	filesManager.run_on_all_of_the_folders(folder_path);
	
}





