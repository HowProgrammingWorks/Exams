// Validate person name
'use strict'

const Valid = (name) => {
if (name === '') return false;
if (typeof name !== 'string') return false;
for (const words of name) {
    if (words === ' ') continue;
    const a = 'a'.charCodeAt(0);
    const z = 'z'.charCodeAt(0);
    if ( a <= words.toLowerCase().charCodeAt(0) <= z) { 
      return true;
    } 
    else { return false }
  }
}

const result = Valid('Marcus Aurelius');
console.log(result);
