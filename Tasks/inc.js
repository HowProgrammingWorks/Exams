// Increment all numbers in dictionary

let inc_numbers =
	(dict) => {
   		for (key in dict) {
      			let propType = typeof dict[key];
      			if (propType === "number"){
      				dict[key] = dict[key] + 1;
      			}
  		}
  return dict;
  }


const result = inc_numbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);
