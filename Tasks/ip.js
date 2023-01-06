// Split string by the first occurrence of separator

// Step 3.
// edit naming
// use for(let i; i <=... ; i++) instead 'for of'
// remove useless j
'use strict';

const Parseip = (ip) => {
  const Box = ip.split('.');
  if (Box.length != 4) return;
  for(let k = 0; k < 4; k++){
    if(isNaN(parseInt(Box[k]))) return;
    Box[k] = parseInt(Box[k]);
  }
  return Box;
};

require('../Tests/ip.js')(Parseip);