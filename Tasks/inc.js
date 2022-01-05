// Increment all numbers in dictionary

"use strict"

const inc_numbers = (format_complete) => {
  const keys = Object.keys(format_complete);
    for (let key of keys) {
      if (typeof format_complete[key] === "number") {
        format_complete[key]++;
      }
    }
    return format_complete;
}


const result = inc_numbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);
