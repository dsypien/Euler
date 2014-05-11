var euler = function(){
	return{
		//Find the sum of all the multiples of 3 or 5 below 1000.
		p1 : function(){
			var sum = 0;
			for(var i =3; i < 1000; i++){
				if( ((i%3) == 0) || ((i%5) == 0) ){
					sum+= i;
				}
			}
			return sum;
		},
		//Considering the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms
		p2 : function(){
			var sum = 2;
			var fib1st = 1;
			var fib2nd = 2;

			while(fib2nd < 4000000){
				var curfib = fib2nd + fib1st;
				if((curfib % 2) == 0){
					sum+=curfib;
				}

				fib1st = fib2nd;
				fib2nd = curfib;
			}
			return sum;
		}
	};

}();