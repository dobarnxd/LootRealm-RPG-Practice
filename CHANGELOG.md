# Version History

## Version 1.0.0 (2025-07-16)  
- Creating the Solution and Game Screen

## Version 1.0.1 (2025-07-16)  
- Creating the Player Class

## Version 1.0.2 (2025-07-16)  
- Creating the GameSession (ViewModel) Class
- Displaying the Player Object
- Update Player data with the PropertyChanged event

## Version 1.0.3 (2025-07-17-19)  
- Creating the Location class, it requires 5 data (x coordinate, y coordinate, name, description and image name)
- Displaying the current location
- Creating the World class to store, add and manage locations
- Creating WorldFactory to manage worlds
- Added buttons to be able to move in the game world

## Version 1.0.4 (2025-07-19)
- Creating a new BaseNotification class to update the property changes on UI
- Making the WorldFactory static

## Version 1.0.5 (2025-07-20)
- Created GameItem class and Weapon class that inherits GameItem
- Added input validation for GameItem and Weapon constructors and properties
- Created ItemFactory to create standard items
- Improved ToString() method in Weapon and GameItem for clearer output
- Displaying the inventory