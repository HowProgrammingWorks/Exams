// Shuffle an array

'use strict';

const INTERVAL_EQUALIZER = 0.5;

const shuffle = (list) => {
  const array = [...list];
  array.sort(() => Math.random() - INTERVAL_EQUALIZER);
  return array;
};

require('../Tests/shuffle.js')(shuffle);
