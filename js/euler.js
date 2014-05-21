var euler = function(){
	function isPalindrome(str){
		if(typeof(str) === "number"){
			str = str.toString();
		}

		for(var i = 0, j = str.length - 1; i < j; i++, j--){
			if(str[i] !== str[j]){
				return false;
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
		},		
		//What is the largest prime factor of the number 600851475143
		p3: function(){
			var num = 600851475143;
			var sqrt = Math.sqrt(num);
			var primes = primes.getFirstN(sqrt);

			for(var i = primes.length; i > 2; i--){
				if(primes[i] !== undefined && (num % primes[i]) === 0){
					alert(primes[i]);
					return primes[i];
				}
			}
		},	
		//Find the largest palindrome made from the product of two 3-digit numbers.
		p4: function(){
			var largestPalindrome = 1;

			for(var i =999; i > 0; i--){
				for(var j= 999; j > 0; j--){
					var product = i * j;
					if(isPalindrome(product) && product > largestPalindrome){
						largestPalindrome = product;
					}
				}
			}
			return largestPalindrome;
		},
		//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
		p5: function(){
			for(var i = 20; ; i+=20){
				for(j = 19; j > 1; j--){
					if(i%j !== 0){
						break;
					}

					if(j == 11){
						return i;
					}
				}
			}
		},
		//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
		p6: function(){
			var sumSquares = 0;
			var sum = 0;

			for(var i=1; i <= 100; i++){
				var square = i * i;
				sumSquares += square;
			}

			for(var i=1; i <=100; i++){
				sum += i;
			}

			var squareSum = sum * sum;

			return squareSum - sumSquares;
		},
		//What is the 10 001st prime number
		p7 : function(){
			var primes = primes.getFirstN(200000);
			return primes[10001 - 1];
		},
		//Largest product in a series
		p8 : function(){
			var series = 	"73167176531330624919225119674426574742355349194934" +
							"96983520312774506326239578318016984801869478851843" +
							"85861560789112949495459501737958331952853208805511" +
							"12540698747158523863050715693290963295227443043557" +
							"66896648950445244523161731856403098711121722383113" +
							"62229893423380308135336276614282806444486645238749" +
							"30358907296290491560440772390713810515859307960866" +
							"70172427121883998797908792274921901699720888093776" +
							"65727333001053367881220235421809751254540594752243" +
							"52584907711670556013604839586446706324415722155397" +
							"53697817977846174064955149290862569321978468622482" +
							"83972241375657056057490261407972968652414535100474" +
							"82166370484403199890008895243450658541227588666881" +
							"16427171479924442928230863465674813919123162824586" +
							"17866458359124566529476545682848912883142607690042" +
							"24219022671055626321111109370544217506941658960408" +
							"07198403850962455444362981230987879927244284909188" +
							"84580156166097919133875499200524063689912560717606" +
							"05886116467109405077541002256983155200055935729725" +
							"71636269561882670428252483600823257530420752963450";
			var greatestProduct = 1;
			for(var i = 0; i< (series.length - 4); i++){
				var currentProduct = 1;
				for(var j = i; j < (i + 5); j++){
					currentProduct = currentProduct * parseInt( series[j] );
				}

				greatestProduct = (currentProduct > greatestProduct) ? currentProduct : greatestProduct;
			}
			return greatestProduct;
		},
		//Special Pythagorean triplet
		p9: function(){
            
		},
		//Sum of priems bellow 2 million
		p10:function(){
			var p = primes.getFirstN(2000000);
			var sum = 0;
			for(var i=0; i < p.length; i++){
			 	sum += p[i];
			}
			return sum;
		}
	};

}();