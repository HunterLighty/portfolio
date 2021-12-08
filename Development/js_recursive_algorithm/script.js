// JavaScript Document
var num;
var answer;


function updateandrun(){
	num = Number(document.getElementById("boxcontent").value);
	answer = Number(document.getElementById("boxcontent").value);
	math();
	window.alert("Answer is " + answer);
}



function math(){
	
	if (num <= 2){
		return answer;
	}
	else{
		answer =  answer * (num - 1);
		num --;
		math();
	}
}


