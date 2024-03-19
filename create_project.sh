#!/usr/bin/env bash

green="\033[1;32m"
reset="\033[m"

# Assign the directory name to a variable
directory_name="stack"

# Check if the directory exists
if [ ! -d "$directory_name" ]; then
    echo -e "${green}Creating directory: $directory_name${reset}"
    mkdir "$directory_name"
else
    echo -e "${green}Directory already exists: $directory_name${reset}"
fi

cd "$directory_name" || exit

# Prompt the user for input
read -p "Enter project name: " project_name

echo -e "${green}Creating console project: $project_name${reset}"
dotnet new console -n "$project_name"

cd ..

echo -e "${green}Adding project to the solution${reset}"
dotnet sln add "$directory_name/$project_name/$project_name.csproj"

echo -e "${green}Executing dotnet restore${reset}"
dotnet restore

echo -e "${green}Finished!${reset}"
