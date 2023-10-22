# Rock Band Generator Documentation
The Rock Music Band Generator is a console application that allows you to create a rock music band with a unique name or create a name yourself from a provided list of adjective and nouns, as well as give a full lineup of members.

## Installation Steps
1. **Download the Application:**
   - Click on "Releases" on the right side, then download the latest release (band_generator.zip file).
    - Extract the ZIP file to your preferred location on your computer.
2. **Run the application:**
    - Open the extracted folder.
    - Find the executable file (it's named "Visma QA task.exe"), and double-click on it.
## Using the Application
Once you've launched the application, you'll see a menu with various options. Here's how to use them:

1. **Generate a Random Band Name:**
   - Select option 1 from the menu to generate a random band name for your band.
2. **Choose Your Band Name:**
   - Select option 2 to create a custom band name. You'll be prompted to choose an adjective and a noun from a list.
3. **Add Band Members:**
   - Select option 3 to add band members to your band. The application will automatically assign roles to them.
4. **View Band Information:**
   - Select option 4 to see your band's name and lineup.
5. **Show Adjective and Noun Count:**
   - Select option 5 to see how many adjectives and nouns are available for band names.
6. **Add New Adjective:**
   - Select option 6 to add a new adjective to the list.
7. **Add New Noun:**
   - Select option 7 to add a new noun to the list.
8. **Regenerate Band:**
   - Select option 8 to start over and regenerate the band name and lineup.
9. **Remove Band Member:**
   - Select option 9 if you want to remove a band member.
10. **Exit:**
    - Select option 10 when you're done with the application.
## Error Handling
The code includes error handling to provide feedback and prevent issues caused by invalid user inputs:
- **Invalid Menu Choices**: When a user enters a choice outside the 1-10 range, the code responds with "Invalid choice! Try again."
- **Invalid Input for Band Member Removal**: When a user enters an invalid band member index to remove (not a valid number or out of range), the code responds with "Invalid band member selection!"
- **Invalid Input for Adjective and Noun Selection**: When a user enters an invalid index while choosing adjectives and nouns for a custom band name, the code responds with "Invalid adjective selection!" or "Invalid noun selection!"
- **Full Band**: If a user tries to add a band member when the band is already full, the code responds with "Band is already full! Cannot add more members."
- **No Members to Remove**: If a user tries to remove a band member when there are no members, the code responds with "The band has no members to remove!"
- **Invalid Input for Menu Choice**: If the user enters a non-integer value when choosing a menu option, the code responds with "Invalid input! Please enter a valid option."
## Additional Information
The application follows a strict lineup for the band: Vocalist, Electric Guitarist, Drummer and Bass Guitarist.<br>
You press **ENTER** on your keyboard when you want to input your selection.<br>
![Screenshot_8](https://github.com/DeividasVal/Visma-QA-task/assets/105603552/e61747ca-6498-4fe5-9e96-348cbfcc71d6)<br><br>
If you encounter any issues while using the application, please contact me for assistance.
