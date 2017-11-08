#include "stdafx.h"
#include <iostream>
#include <string>
#include <iostream>
#include "dirent.h"
#include <vector>
#include "FileCopier.cpp"
#include "GradleHandler.cpp"

using namespace  std;

class FilesManager
{
public:

	void run_on_all_of_the_folders(string foldersPath)
	{
		cout << "looking for all folders in foldersPath: " << foldersPath;

		DIR *dir;
		struct dirent *ent;

		const char* lock_path = foldersPath.c_str();
		if ((dir = opendir(lock_path)) != NULL) {

			//here i run on all of the ENTRIES
			while ((ent = readdir(dir)) != NULL) {

				string folder_name = (string)ent->d_name;
				int type_of_file = ent->d_type;


				if (type_of_file != DT_DIR || folder_name == "." || folder_name == "..")continue;
				string folderPath = foldersPath + "\\" + folder_name;
				run_on_specific_folder(folderPath);
			}
		}

	}


	FilesManager::FilesManager(string filePath, string libName) {
		FilesManager::filePath = filePath;
		FilesManager::libName = libName;
		gradleHandler = new GradleHandler();
	}


private:
	string filePath, libName;

	GradleHandler* gradleHandler;

	//static finals
	string APP = "app";
	string BUILD_GRADLE = "build.gradle";

	void run_on_specific_folder(string folder_path)
	{
		cout << "\n\nlooking in folder " << folder_path;

		DIR *dir;
		struct dirent *ent;

		const char* lock_path = folder_path.c_str();
		if ((dir = opendir(lock_path)) != NULL) {

			//here i run on all of the ENTRIES
			while ((ent = readdir(dir)) != NULL) {

				//if it's the folda
				string fileName = (string)ent->d_name;

				if (fileName == APP)
				{
					run_on_specific_folder(folder_path + "\\" + APP + "\\");
				}
				else if(fileName == BUILD_GRADLE && (folder_path.find(+"\\"+APP+"\\") != string::npos))
				{
					gradleHandler -> changeGradleVersion(folder_path + BUILD_GRADLE);
					return;
				}

				else if (fileName == libName)
				{
					string fileNameWithExtension = filePath.substr(filePath.find_last_of("\\") + 1);
					string currentPathModified = folder_path + "\\" + fileName + "\\";
					string currentPathModified2 = currentPathModified  + fileNameWithExtension;

					const char* dest = (currentPathModified2).c_str();
					remove(dest);
					bool copied = FileCopier::copy_file(filePath.c_str(), dest);
					if (copied)
						cout << "\n\ncopied to : " << dest << "\n";
					return;
				}
			}
		}
	}
};



