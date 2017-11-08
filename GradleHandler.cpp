#include "stdafx.h"
#include <string>
#include <iostream>
#include <fstream>
#include <sstream>


using namespace std;
class GradleHandler{

public:
	string sum;

	const string VERSION_CODE = "versionCode";

	const string VERSION_NAME = "versionName";

	char const* OLD_GRADLE_FILE = "old gradle file";

	void changeGradleVersion(string gradleFilePath)
	{
		cout << "\n\n found gradle path: " << gradleFilePath;
		
		//input stream
		ifstream inFile;
		inFile.open(gradleFilePath);

		//output stream
		ofstream fileout(gradleFilePath+"2");

		if (!inFile || !fileout) {
			cerr << "Unable to open file datafile.txt";
			exit(1);   // call system to stop
		}
		
		string gradleFileTxt;
		string currentLine;
		while (getline(inFile, currentLine)) {

			//contains!
			if (currentLine.find(VERSION_CODE) != string::npos)
			{
				int versionCode = stoi(currentLine.substr(currentLine.find_last_of(" ")+1));
				currentLine = currentLine.substr(0, currentLine.find_last_of(" ")+1) + to_string(versionCode +1 );
			} 
			
			else if (currentLine.find(VERSION_NAME) != string::npos)
			{
				currentLine = incrementVersionName(currentLine);
			}

			gradleFileTxt += currentLine + "\n";
		}

		fileout << gradleFileTxt;

		fileout.close();

		inFile.close();
		bool k =  remove(gradleFilePath.c_str());
		rename((gradleFilePath +"2").c_str(), gradleFilePath.c_str());

	}

	string incrementVersionName(string versionNameLine)
	{
		int start = versionNameLine.find_first_of("\"")+1;
		int end = versionNameLine.find_last_of("\"");
		int versionDigitsCount = end - start;
		
		string versionName = versionNameLine.substr(start, versionDigitsCount);
		char digits[] = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
		for (int i = versionDigitsCount-1; i > -1; i-=2)
		{
			int currentDigit = versionName[i] - '0';
			if (currentDigit < 9){
				
				char newDigit = currentDigit + 1;
				versionName[i] = newDigit + '0';
				break;
			}
			
			else if(i !=0 ){
				versionName[i] = '0';
			}
			else
			{
				string newDigit = to_string((currentDigit + 1));
				if (versionName.find("."))
					versionName = newDigit + versionName.substr(versionName.find_first_of("."));
				else
					versionName = newDigit;
				break;
			}
		}
		
		versionNameLine = versionNameLine.substr(0, start) + versionName + "\"";
		return versionNameLine;
	}
};
