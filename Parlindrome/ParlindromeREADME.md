# Parlindrome
parlindrome is a word that can be spelt same way from right to left or left to right and still mean the same

## Examples
- WOW
- MUM
- DAD
- etc

## Technique used 
Linear search (loop through the collection ones)

## Time Complexity
The time complexity for this solution resolves to O(n)/2. <br/>
Instead of looping the full length to compare the characters, I looped half way comparing the first indexed character with it's last corresponding index.
So in the loop I was comparing two opposite characters at once instead of one and that reduced the time it would normally take to go throught the full length.

## Get Started with this app.

### On Windows using Visual studio IDE

Clone this repo and run the solution file, Preferably using visual studio 2019. Simply by clicking the soliution file in the package named ('WalkingSkeleton.sln'). Visual studio IDE will open the solution file, and the internal server IIS will open it in your default browser

### On Windows Or Linux using VSCODE or (Other editor of choice)

Clone this repo and

Change directory to the root folder 'WalkingSkeleton'. Open the folder containting the solution file in VSCode text editor (Preferably) or other text editor of choice. Execute a build command ('dotnet build') to resolve any dependencies. Execute the run command ('dotnet run')
