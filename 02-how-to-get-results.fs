: yd>in 36 * ;
: ft>in 12 * ;

( always inches )
: yd 36 * ;
: ft 12 * ;
: in ;

10 yd>in .
2 ft>in .
10 yd 2 ft + 9 in + .


: 5#sum + + + + ;
17 20 132 3 9 5#sum .

cr
: mph ; : hr ;
: speed 600 mph ; : tail -25 mph ; : time 5 ;
: flight-distance + * ;
time speed tail flight-distance .
10 500 0 flight-distance .

cr
: solution + * ; ( n1 n2 n3 -- res )

( definition style practice problems )
: a1 42 ; : b1 12 ; : c1 2 ;
: 2b1 ( c a b -- n ) 4 * - 6 / + ;
: 2b2 ( a b -- n ) 8 * / ;
: 2b3 ( a b -- n )  * 200 / ;
: 2b4 ( a a -- n ) 2 * 3 + * ;
: 2b5 ( c a b -- n ) - / ;

c1 a1 b1 2b1 .
a1 b1 2b2 .
a1 b1 2b3 .
a1 a1 2b4 .
c1 a1 b1 2b5 . ( impossible at this stage )
cr

: quarters 4 /mod . ." ones and " . ." quarters " ;
22 quarters

cr
: use-swap ( c a b -- n ) - swap / . ;
3 20 8 use-swap

bye
