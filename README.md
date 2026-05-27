**Why must passwords not be stored as plain text?**
  If the database leak happens, then attackers can immideately see and use leaked passwords. The problem gets worse if people use same or familiar passwords accross multiple platforms.
**Why is raw SHA-256 not a good choice for passwords?**
  As it is designed to be fast, so it can be brute-forced more easily
**Why do we use salt?**
  To make same passwords have different caches, so if one is decrypted, it doesn't disclose other passwords
**What is the difference between salt and pepper?**
  Salt is used individually per password, pepper is a secret application level key.
**What is the difference between authentication and authorization?**
  Authentication is responsible for verifying users identity, while authorization is about what rights he has.
**Why is hiding a link in a view not enough as security?**
  Because even if link is hidden, it still can be typed explicitly by an attacker into the adress bar. The controller must reject unauthorized requests.
**Why can a "there is no such user" login message be a problem?**
  It gives possible attacker more information on his attack progress, as in other case he wouldn't know if he typed email or password incorrectly. With this kind of message, he already knows that mail or username is the issue.
