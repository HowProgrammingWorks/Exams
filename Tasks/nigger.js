'use strict';
const Words = (string) => {
  let counter = 0
  let flag = false
  for (const c of string) {
    if (!flag) { if (c !== ' '){flag = true; counter++;}}
    else {if (c === ' ') {flag = false}}
  }
  return counter;
}
   const result = Words('Hello Marcus Aureluis');
   console.log(result);