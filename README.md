

- detect when two racers from different groups pass two consecutive sensors within 3 seconds

- “cheating computer” observers and encapsulates a list of detected cheaters

- List of Cheaters should be observable so racer official can receive notifications


- spectators and support teams should be able to subscribe to receiving data for multiple racers
    - every 5 minutes or whenever there is a significant change in the relative positions of the racers
    - observer needs the real person’s name and email

    - staff person can customize the emails that get send to spectator or support team
        - Automatically add a header (Hi "George")
        - Footer (Organization name)
        - p.s.


- Race promoters can set up screen showing who is winning (state of 1-30 racers)


- Staff Person (Running the program)
    - Observe cheaters (Emails)

- race prompters
    - Observe status/placement (Emails)

- Screen
    - Placement








# Simulator (sensors)

- CSV file containing a list race groups
    - group number
    - label
    - start time
    - min / max bib numbers

- Send Race Status to server

- Racer Status Message (JSON)
    - Sensor Id
    - Racer bib number
    - Time (since start of first group)

- Times are realistic, but sent at quicker pace. (6-12 hours => 2-4 minutes)




- One class: receiving and process of racer status messages