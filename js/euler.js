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
		},
		//What is the greatest product of four adjacent numbers in the same direction 
		//(up, down, left, right, or diagonally) in the 20×20 grid?
		p11:function(){
			var grid = [[ 8,  2, 22, 97, 38, 15,  0, 40,  0, 75,  4,  5,  7, 78, 52, 12, 50, 77, 91,  8],
						[49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48,  4, 56, 62,  0],
						[81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30,  3, 49, 13, 36, 65],
						[52, 70, 95, 23,  4, 60, 11, 42, 69, 24, 68, 56,  1, 32, 56, 71, 37,  2, 36, 91],
						[22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80],
						[24, 47, 32, 60, 99,  3, 45,  2, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50],
						[32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70],
						[67, 26, 20, 68,  2, 62, 12, 20, 95, 63, 94, 39, 63,  8, 40, 91, 66, 49, 94, 21],
						[24, 55, 58,  5, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72],
						[21, 36, 23,  9, 75,  0, 76, 44, 20, 45, 35, 14,  0, 61, 33, 97, 34, 31, 33, 95],
						[78, 17, 53, 28, 22, 75, 31, 67, 15, 94,  3, 80,  4, 62, 16, 14, 09, 53, 56, 92],
						[16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57],
						[86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58],
						[19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40],
						[04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66],
						[88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69],
						[04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36],
						[20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16],
						[20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54],
						[01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48] ];
			var greatestProduct = 0;

			for(var row = 0; row < 20; row++){
				for(var col=0; col <20; col++){
					var product = 0;
					// can do down
					if(row < 17){
						var downP = grid[row][col] * grid[row + 1][col] * grid[row +2][col] * grid[row + 3][col];
						greatestProduct = downP > greatestProduct ? downP : greatestProduct;
					}
					// can do right
					if(col < 17){
						var rightP = grid[row][col] * grid[row][col + 1] * grid[row][col + 2] * grid[row][col + 3];
						greatestProduct = rightP > greatestProduct ? rightP : greatestProduct;
					}
					// can do diagonal
					if(col < 17 && row < 17){
						var diagonalP = grid[row][col] * grid[row + 1][col + 1] * grid[row + 2][col + 2] * grid[row + 3][col + 3];
						greatestProduct = diagonalP > greatestProduct ? diagonalP : greatestProduct;
					}
				}
			}

			return greatestProduct;				
		}
	};

}();