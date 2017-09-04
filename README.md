# ConsoleSocialNetworking
Implement a console based social networking application similar to twitter:
## How to Run 
Download Repository
### Opt 1: 
- Open project in visual studio 2015 
- Set to release and select Build -> Build Solution
- Navigate to bin/release directory and run ConsoleSocialNetworking.exe
### Opt 2:
- Download MSBuild for VS2015 
- Open MSBuild Command prompt and cd to repository directory ConsoleSocialNetworking Folder
- run MSBuild.exe /t:Build /p:Configuration=Release ConsoleSocialNetworking.csproj
- Navigate to bin/release directory and run ConsoleSocialNetworking.exe
## How to Use
### Posting: Alice can publish messages to a personal timeline
\> Alice -> I love the weather today

\> Bob -> Damn! We lost!

\> Bob -> Good game though.
### Reading: I can view Alice and Bob’s timelines
\> Alice

I love the weather today (5 minutes ago)

\> Bob

Good game though. (1 minute ago)

Damn! We lost! (2 minutes ago)
### Following: Charlie can subscribe to A​lice’s and B​ob’s timelines, and view an aggregated list of all
subscriptions
\> Charlie -> I'm in New York today! Anyone want to have a coffee?

\> Charlie follows Alice

\> Charlie wall

Charlie - I'm in New York today! Anyone want to have a coffee? (2 seconds ago)

Alice - I love the weather today (5 minutes ago)

\> Charlie follows Bob

\> Charlie wall

Charlie - I'm in New York today! Anyone wants to have a coffee? (15 seconds ago)

Bob - Good game though. (1 minute ago)

Bob - Damn! We lost! (2 minutes ago)

Alice - I love the weather today (5 minutes ago)
