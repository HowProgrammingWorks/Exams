// Increment all numbers in dictionary

let inc_numbers =
	(dict) => {
   		for (key in dict) {
      		
      		if ((typeof dict[key]).charAt(0).toUpperCase() ==='N'){
      			dict[key] = dict[key] + 1;
      		}
  		}
  return dict;
  }


const result = inc_numbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);
