var euler = function(){
	// return an array of the first n prime numbers
	function getFirstNPrimeNumbers_slow(n){
		var primes = [];

		for(var i =2; i < n; i++){
			var half = Math.floor(i /2 );

			// check if current i is a prime
			var isPrime = true;
			for(var j=2; j <= half; j++){
				if((i % j) == 0){
					isPrime = false;
					break;
				}
			}

			if(isPrime){
				primes.push(i);
			}
		}

		return primes;
	}

	function getFirstNPrimeNumbers(n){
		var primes = [2];

		for(var i =3; i < n; i+= 2){
			if(isPrime(i)){
				primes.push(i);
			}
		}

		return primes;
	}

	function sieves(n){
		var mem = {};
		var sqrt = Math.floor(Math.sqrt(n));

		for(var i =2; i <=sqrt; i++){

			for(var j = i; j < n; j += i){
				if(i === j && mem[i] ===undefined){
					continue;
				}

				mem[j] = true;		
			}
		}

		var primes = [];
		for(var i = 2; i < n; i++){
			if(mem[i] === undefined){
				primes.push(i);
			}
		}

		return primes;
	}

	function isPrime(n){
		var half = Math.floor(n /2 );


		for(var j=2; j <= half; j++){
			if((n % j) == 0){
				return false;
				break;
			}
		}
		return true;
	}

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

}();