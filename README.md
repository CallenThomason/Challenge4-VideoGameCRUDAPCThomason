## Callen Thomason
9/23/2026
Video Game CRUD API
I used controllers, models, and now services to create an organized API for video game storage. All of the logic resides in the services, keeping the controller 'cleaner'. I created a GetByAvailabilty very similarly to a getByGenre, but it did not require a parameter. Availabity could only be true or false, so we just look for the ones that are true. I used FirstOrDefault anywhere I needed to sift through the data and pull out specific games. 
Reviewer: Zionn Showers
Review: Searching by genre seems to be bugged since the genre names have /'s in them, confusing the web browser since it already uses /'s for its pages. Everything else, however, works as intended.