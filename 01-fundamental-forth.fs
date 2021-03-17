( Large letter F )
: star 42 emit ;
: stars 0 do star loop ;
: margin cr 30 spaces ;
: blip margin star ;
: bar margin 5 stars ;
: f bar blip bar blip blip cr ;

f

( Greet )
: greet ." hello! i speak forth" ;

greet

bye
