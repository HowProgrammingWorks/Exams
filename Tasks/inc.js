'use strict'

const inc = (format) => {
  let res = [];
     for ( let element of format){
      if (typeof element === "number") element ++;
      res.push(element);
   }
  return res;
  };


const obj = [1,2,'hello', false];
console.log(inc(obj));
