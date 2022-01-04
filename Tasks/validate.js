// Validate person name
'use strict'

const valid = (name) => {
  if (typeof name !== 'string') return false;
  for (const words of name) {
     const a = 'a'.charCodeAt(0);
     const z = 'z'.charCodeAt(0);
     if ( words.toLowerCase().charCodeAt(0) < a || words.toLowerCase().charCodeAt(0) > z) {
      return false;
     }
    return true;
  }
}

const result = valid ('Marcus Aurelius');
console.log(result);
