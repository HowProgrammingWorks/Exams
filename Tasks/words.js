// Count words in a string

Words = function (s) {
  number_of_words_in_s = 0;
  flag = false;
  for (c of s) {
    if (!flag) {
      if (c === ' ') flag = false; 
       else {
            flag = true;
            number_of_words_in_s++;
      }
    }else {
      if (c === ' ') flag = false;
       else  flag = true; 
    }
  }
  return number_of_words_in_s;
};

require('../Tests/words.js')(Words);
