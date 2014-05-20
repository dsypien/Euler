var primes = (function(){
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
		isPrime : function(n){
			return isPrime(n);
		},
		getFirstN : function(n){
			return sieves(n);
		}
	};
}());