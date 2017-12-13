# EnergonServices

Backend services

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api

# Notes

* matchmaking API adds/removes players in queue
* "master" matchmaker locks queue and follows "queue instructions" to set who is currently looking for matches (unlocking queue when done)
  * only do this every so often (configurable)
* finding "the best matches" is parallelizable
  * "master" matchmaker distributes set of players to each "slave" matchmaker
  * "slave" matchmakers look through set of players to score all possible matches and send those scores back to the "master"
  * "master" matchmaker sorts scores and creates all matches above a threshold that contain players who have not yet been put in a matches
    * keep a hash set of players who have been put into matches
    * need a configurable score threshold
* matchmaking formula:
  * ((1 / (player_score - average_player_score)) * player_score_weight) + ((player_wait_time) * wait_time_weight)
* edge cases:
  * what about "late joins"?