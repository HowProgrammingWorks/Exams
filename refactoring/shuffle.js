// Shuffle an array

'use strict';

const INTERVAL_EQUALIZER = 0.5;
const Shuffle = (List) => {
  const arr = [...List];
  arr.sort(() => Math.random() - INTERVAL_EQUALIZER);
  return arr; 
};

require('../Tests/shuffle.js')(Shuffle);
