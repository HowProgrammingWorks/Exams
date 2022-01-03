'use strict'

const inc = elements => {
   for (let key of elements) {
      if ((typeof elements[key]).charAt(0).toUpperCase() ==='N'){
        elements[key] = elements[key] + 1}
   }
  return elements;
  }


const result = inc_numbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);
