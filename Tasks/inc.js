'use strict'

const inc = elements =>{
     for ( let key in elements)
      {
      if ((typeof elements[key]) == "number")
      {
        elements[key] = elements[key] + 1;
      };
   };
  return elements;
  }


const obj = ({ a: 1, b: 2, c: 'hello', d: false });
console.log(inc(obj));
