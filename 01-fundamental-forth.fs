( Large letter F )
: star 42 emit ;
: stars 0 do star loop ;
: margin cr 30 spaces ;
: blip margin star ;
: bar margin 5 stars ;
: f bar blip bar blip blip cr ;
( f )

( Greet )
: greet ." hello! i speak forth" ;
( greet )


( 4 3 + . )
: fm 4 + ;
( 3 fm . 10 fm . )
( -10 fm .
)

(	the stack is like a big global variable
	i wonder if this creates issues
	what about scope?
	can we just have multiple scopes?

	a language with separate but otherwise public stacks would be cool
	also, for secutiy it'd be cool to give the option of privatizing
		stack acces.
)






( problems )


( problem 1 )
: gift ." life" ; : giver ." zorain " ;
: thanks cr ." dear " giver ." thanks for this " gift cr ;
thanks


( problem 2 )
: ten.less 10 - . cr ;
4 ten.less


( problem 3 )
: giver ." tinami" ;
thanks



bye
