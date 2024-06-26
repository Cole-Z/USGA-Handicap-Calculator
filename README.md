### Handicap Calculator

### App start up
![image](https://github.com/Cole-Z/CIS262_Final-/assets/98670265/0d41c219-cd81-4d40-b33e-66354d4474bf)

Program will allow for handicap index calculation for players based on the number of rounds in the system for that player.

Users can also add additional courses and/or add more players to the list.

Player data and course data is stored in the /bin dir of the project. Everytime a new player is added, it will add that player to the master list, and in order for scores to be calculated, rounds need to be added per player so their scoring list can be generated.

## Functionality

USGA Calculation Mehod: "Your Handicap Index is a portable number that represents your demonstrated golfing ability. It is based on your past scores relative to the difficulty of the course and tees played, as well as the playing conditions during each one of those rounds.
To calculate your Handicap Index, your 8 best Score Differentials from your most recent 20 scores"

In code: 

Calculating player differential based on the course rating and slope

```
round/differential = (score - courseRating) * 113 / slopeRating;

```
Calculating handicap index based on the players differential/round list
```
Math.Round(handicapIndexSum / 8, 1);
```

To calculate your Handicap Index, your 8 best Score Differentials from your most recent 20 scores are averaged

Each player will need 20 rounds in order for the index to be calculated. Formula is based off of the USGA's handicap index equation.

![image](https://github.com/Cole-Z/CIS262_Final-/assets/98670265/99191db1-9136-4702-9ece-28e27b2476f2)

If a player does not meet the 20 round requirement, then a messagebox will display the issue to the user.

![image](https://github.com/Cole-Z/CIS262_Final-/assets/98670265/ab9b9ae0-b225-4545-a587-cd7b11c8d146)

Once a user reaches 20 rounds, then the index will be automatically calculated once 20 differentials are in the player list.

Less than 20 Rounds:

![image](https://github.com/Cole-Z/USGA-Handicap-Calculator/assets/98670265/ecdd8401-07ea-4378-8dc6-8c0c36b3174a)

Requirement met at 20 Rounds:

![image](https://github.com/Cole-Z/USGA-Handicap-Calculator/assets/98670265/1486635b-d670-461e-b58e-57fa02c139a2)

## About

I used to be an assistant golf pro, and a common issue I ran into with members or existing players was that some did not have a handicap calculated and in order to compete in some tournaments, players must have a handicap index.
This allows for a lightweight index calculation if you needed to get an index on the fly. Also, it could be used for golf trips in case money games are played. Some may ask, "well why dont you just use the GHIN system from the USGA?" and to answer that, the GHIN system usually costs money for the membership and more than likely you will need to belong to a country club. This helpe mitigate that to get a true index.

### Disclaimer

As of now, the Tee's used for the courses will always be the tips (In the future, I plan to add more tee options to better adjust for handicap), but as of now since this is designed for competition, we will use the back tees for every course upload.


