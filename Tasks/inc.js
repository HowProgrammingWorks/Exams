// Increment all numbers in dictionary

"use strict"

const inc_numbers = dict => {
   	for (let key in dict) {
      		if (typeof dict[key] === "number"){
      			dict[key]++;
      		}
  	}
  	return dict;
 };


const result = inc_numbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);
