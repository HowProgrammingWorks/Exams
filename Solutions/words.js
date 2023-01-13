'use strict'

const Words = (s) => {
  return ((s === '') ? 0 : s.split(" ").length);
};

require('../Tests/words.js')(Words);