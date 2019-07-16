.animate span{
	display: block;
	position: relative;
	text-align: center;
}

.animate.backwards > span{
	animation: animateBackwards 1s ease-in-out
forwards;
}
.animate.forwards > span{
	animation: animateForwards 1s ease-in-out
forwards;
}

.animate.mixed > span:nth-child(even){
	animation: animateBackwards 1s ease-in-out
forwards;
}
.animate.mixed > span:nth-child(odd){
	animation: animateForwards 1s ease-in-out
forwards;
color: greenyellow;
}
@keyframes animateForwards {
	from { top: 0; transform: rotate(0deg); }
	to { top: .9em; transform: rotate(-25deg); }
}
@keyframes animateBackwards {
	from { top: 0; transform: rotate(0deg); }
	to { top: 1em; transform: rotate(35deg); }
}

/*colours*/
.animate.forwards {
  color: rgb(0, 238, 255);
}
.animate.mixed {
  color: rgb(190, 12, 161);
}
