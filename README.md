# PassGen
Simple program that allows you to organize your passwords.

# How does it work?
After you pick name and expected password lenght, script runs `for` loop.
This loop provides random number in range `0-72` after every turn, then it converts it to index of `charArr` array. Char labeled with this index is being added to `Pass` array, which at the end contains final password.

# Write it down!
Using **StreamWriter** class this script will create text file named `PassAll` on your desktop, which is being modified everytime when you create new password with `PassGen`.

### Beta info:
If you want your file to be continously updated with your new passwords,
do not move `PassAll.txt` from desktop. 

If you are skilled, you can change directory for file to save in `54 line`

# Feel free to visit my [website](http://typical.ct8.pl)
