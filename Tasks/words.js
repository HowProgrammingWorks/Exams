// Count words in a string

//Step 1
//Remove recurring conditions and branches
//Add 'use strict'

'use strict'

Words = function (s) {
  number_of_words_in_s = 0;
  flag = false;
  for (c of s) {
    if (!flag) {
      if (c === ' ') {
          flag = false;
          flag = true;
        number_of_words_in_s++;
      }
    } else {
      if (c === ' ')
          flag = false;
          flag = true; 
      }
    }
  return number_of_words_in_s;
};

require('../Tests/words.js')(Words);
