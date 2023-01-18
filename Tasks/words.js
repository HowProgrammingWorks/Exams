// Count words in a string

const Words = (s) => {
  let number_of_words_in_s = 0;
  let flag ;
  for ( c of s) {
    if (!flag)   number_of_words_in_s++; 
      c === ' ' ? flag = false : flag = true;
  }
  return number_of_words_in_s;
}
require('../Tests/words.js')(Words);

