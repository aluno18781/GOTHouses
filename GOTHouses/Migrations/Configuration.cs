namespace GOTHouses.Migrations
{
    using GOTHouses.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GOTHouses.Models.GOTHousesDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GOTHouses.Models.GOTHousesDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var house = new List<Houses>
            {
                new Houses { Id=1, Name="House Stark", Symbol="https://vignette.wikia.nocookie.net/gameofthrones/images/8/8a/House-Stark-Main-Shield.PNG/revision/latest?cb=20170101103142", Description="House Stark of Winterfell is a Great House of Westeros, ruling over the vast region known as the North from their seat in Winterfell. It is one of the oldest lines of Westerosi nobility by far, claiming a line of descent stretching back over eight thousand years. Before the Targaryen conquest, as well as during the War of the Five Kings and Daenerys Targaryen's invasion of Westeros, the leaders of House Stark ruled over the region as the Kings in the North. Their rule in the North seemingly ended after the events of the Red Wedding when House Frey and House Bolton betrayed House Stark after forming a secret alliance with House Lannister, during which Roose Bolton murdered King Robb Stark. Both the North and Winterfell were taken over by House Bolton. However, the Bolton's hold was jeopardized when Sansa Stark escaped their clutches after learning her brothers Bran and Rickon Stark were still alive and reunited with her half-brother Jon Snow at Castle Black. Sansa and Jon marched on the Boltons to save their younger brother Rickon, who was later murdered by Ramsay Bolton, and retake their family home Winterfell. House Stark was restored to their former stature after the Battle of the Bastards. The Stark victory led to House Stark's return to royal status in the North with their bannermen declaring Ned Stark's illegitimate son Jon Snow as the King in the North. He later abdicated his title as king in order to gain the full support of Daenerys Targaryen in the Great War, becoming the Warden of the North. House Stark's sigil is a grey direwolf on a white background, over a green escutcheon. They are one of the few noble Houses whose family motto is not a boast or threat. Instead, the House Stark family motto is a warning, one that, no matter the circumstances, will always be relevant: 'Winter Is Coming.' " },
                new Houses { Id=2, Name="House Targaryen", Symbol="https://vignette.wikia.nocookie.net/gameofthrones/images/4/43/House-Targaryen-Main-Shield.PNG/revision/latest?cb=20170510235320", Description="House Targaryen of Dragonstone is a Great House of Westeros and was the ruling royal House of the Seven Kingdoms for three centuries since it conquered and unified the realm, before it was deposed during Robert's Rebellion and House Baratheon replaced it as the new royal House. The two surviving Targaryens fled into exile to the Free Cities of Essos across the Narrow Sea. Currently based on Dragonstone off of the eastern coast of Westeros, House Targaryen seeks to retake the Seven Kingdoms from House Lannister, who formally replaced House Baratheon as the royal House following the destruction of the Great Sept of Baelor. House Targaryen's sigil is a three-headed red dragon on a black background, and their house words are 'Fire and Blood.'" },
                new Houses { Id=3, Name="House Lannister", Symbol="https://vignette.wikia.nocookie.net/gameofthrones/images/8/8a/House-Lannister-Main-Shield.PNG/revision/latest?cb=20170101095357", Description="House Lannister of Casterly Rock is one of the Great Houses of Westeros, one of its richest and most powerful families and oldest dynasties. It is also the current royal house of the Seven Kingdoms following the extinction of House Baratheon of King's Landing, which had been their puppet house anyway. The Lannisters rule over the Westerlands. Their seat is Casterly Rock, a massive rocky promontory overlooking the Sunset Sea which has had habitations and fortifications built into it over the millennia. They are the Lords Paramount of the Westerlands and Wardens of the West. As the new royal house, they also rule directly over the Crownlands from their seat of the Red Keep in King's Landing, the traditional seat of the royal family. House Lannister's Heraldry consists of a golden lion on a crimson background, and their House words are 'Hear me roar!', which is rarely mentioned. Their unofficial motto, which is as well known as the official one, is 'A Lannister always pays his debts' - which is used much more often and mostly in negative context, though it can also be used in the original, literal sense." },
                new Houses { Id=4, Name="House Greyjoy", Symbol="https://vignette.wikia.nocookie.net/gameofthrones/images/8/86/House-Greyjoy-Main-Shield.PNG/revision/latest?cb=20170523015836", Description="House Greyjoy of Pyke is one of the Great Houses of Westeros. It rules over the Iron Islands, a harsh and bleak collection of islands off the west coast of Westeros, from the castle at Pyke. The head of the house is the Lord Reaper of Pyke. House Greyjoy's sigil is traditionally a golden kraken on a black field. Their house words are 'We Do Not Sow' although the phrase 'What Is Dead May Never Die' is also closely associated with House Greyjoy and their bannermen, as they are associated with the faith of the Drowned God. House Greyjoy had been in open rebellion against the Iron Throne since the War of the Five Kings, during which it sought independence for the Iron Islands once more.However, following the death of King Balon Greyjoy and the election of his brother, Euron, as the new King of the Iron Islands, House Greyjoy was divided between Euron and his followers, and Balon's surviving children, Yara and Theon, and their followers. Yara's faction, which had aligned with House Targaryen, was defeated by Euron, who has aligned himself with House Lannister upon the beginning of Daenerys Targaryen's invasion of Westeros." },
                new Houses { Id=5, Name="House Baratheon", Symbol="https://vignette.wikia.nocookie.net/gameofthrones/images/0/00/House-Baratheon-Main-Shield.PNG/revision/latest?cb=20170519002924", Description="House Baratheon of Storm's End is a legally extinct Great House of Westeros. A cadet branch was formerly the royal house, but House Lannister now controls the throne. House Baratheon traditionally ruled the Stormlands on the eastern coast of Westeros, aptly named for its frequent storms, from their seat of Storm's End. House Baratheon became the royal house of the Seven Kingdoms after Robert Baratheon led a rebellion against the Targaryen dynasty. At the end of the rebellion, Robert ascended the Iron Throne as Robert I and married Cersei Lannister after the death of Lyanna Stark. House Baratheon's sigil is a black stag on a gold background and their house words are 'Ours Is the Fury.' When Robert ascended to the Iron Throne, a gold crown was added to the stag, denoting their status as the royal house. House Baratheon is now legally extinct, but the family bloodline lives on through Gendry, a bastard son of Robert Baratheon and the last known living person with true blood ties to the Baratheon family." },

            };

            house.ForEach(hh => context.Houses.AddOrUpdate(h => h.Id, hh));
            context.SaveChanges();

            var character = new List<Characters>
                {

                new Characters{Id=1, Name="Sansa Stark", Family="Stark", HouseFK=1, Photo="https://s1.r29static.com//bin/entry/b49/0,0,2000,2400/720x864/1804416/image.png", Video="https://youtube.com/watch?v=YzDGc16OHBU",  Description="Sansa Stark is the eldest daughter and second child of Lady Catelyn and Lord Eddard Stark. Eddard is the head of House Stark and Lord Paramount of the North. The North is one of the constituent regions of the Seven Kingdoms and House Stark is one of the Great Houses of the realm. House Stark rules the region from their seat of Winterfell and Eddard also holds the titles of Lord of Winterfell and the Warden of the North to King Robert Baratheon. Sansa was born and raised at Winterfell. She has an older brother, Robb, two younger brothers, Bran and Rickon, a younger sister, Arya, and a 'bastard half-brother' Jon Snow, with whom she had a distant relationship due to her mother's influence (which, like her mother, Sansa later regretted). Sansa enjoys proper 'lady-like' pursuits and is good at sewing, embroidering, poetry, singing, dancing, literature, etiquette, history and music. When she was young she dreamed of being a regal Queen like Cersei Lannister, and that just like in the epic songs she would meet her knight in shining armor. She has inherited her mother's Tully coloring, like most of her siblings, and Lady Catelyn thinks Sansa will be even more beautiful than she was when she was younger. She is often seen in contrast with her sister, Arya Stark who has neither her looks nor her accomplishments in feminine activities and comportment."},
                new Characters{Id=2, Name="Arya Stark", Family="Stark", HouseFK=1, Photo="http://images6.fanpop.com/image/photos/40600000/Arya-Stark-7x04-The-Spoils-of-War-arya-stark-40619657-333-500.jpg", Video="https://youtube.com/watch?v=7JG2KBrrBkA",  Description="Arya Stark is the youngest daughter and third child of Lady Catelyn and Lord Eddard Stark. Eddard was the head of House Stark and Lord Paramount of the North. The North is one of the constituent regions of the Seven Kingdoms and House Stark is one of the Great Houses of the realm. House Stark rules the region from their seat of Winterfell and Eddard also holds the title Lord of Winterfell. He is also the Warden of the North to King Robert Baratheon. Arya was born and raised at Winterfell. She has an older sister, Sansa Stark. She also has an older brother, Robb, two younger brothers, Bran and Rickon and a 'bastard half-brother', Jon Snow. Arya rejects the notion that she must become a lady and marry for influence and power.Instead, she believes that she can forge her own destiny.She is fascinated by warfare and training in the use of arms, and is bored by embroidery and other 'lady-like' pursuits.She takes after her father and has a quarrelsome relationship with her sister Sansa, due to their contrasting interests and personalities.She is close to her 'half-brother' Jon, who is also something of an outsider."},
                new Characters{Id=3, Name="Brandon Stark", Family="Stark", HouseFK=1, Photo="https://files.incrivel.club/files/news/part_9/92510/436660-_0016_Bran_S06E05_2-650-32e9147584-1484652581.jpg", Video="",  Description="Bran is the fourth child and second son of Lady Catelyn and Lord Ned Stark. Ned is the head of House Stark and Lord Paramount of the North. The North is one of the constituent regions of the Seven Kingdoms and House Stark is one of the Great Houses of the realm. House Stark rules the region from their seat of Winterfell and Ned also holds the title Lord of Winterfell. He is also the Warden of the North to King Robert Baratheon. Bran was born and raised at Winterfell. He has an older brother Robb, a younger brother Rickon, two older sisters Sansa and Arya, and an older 'bastard half-brother', Jon Snow, who is actually Bran's first cousin by his aunt Lyanna Stark. Bran was named for Ned's elder brother, Brandon, who was brutally executed by the Mad King along with Bran's paternal grandfather Rickard Stark. He is only called 'Brandon' by his mother when he has done something wrong. Bran dreams of being a knight of the Kingsguard, and his favorite hobby is climbing the walls of Winterfell, using its old rooftops and passageways to get around."},
                new Characters{Id=4, Name="Joffrey Baratheon", Family="Baratheon", HouseFK=5, Photo="https://vignette.wikia.nocookie.net/gameofthrones/images/2/25/Joffrey_Season_4_Episode_2_TLATR.jpg/revision/latest?cb=20171105180252", Video="https://youtube.com/watch?v=HLYNoOWv1os&t=37s",  Description="Joffrey is believed to be the oldest son and heir of King Robert Baratheon and Queen Cersei Lannister, both of whom entered into a political marriage alliance after Robert took the throne by force from the 'Mad King' Aerys II Targaryen. In reality, his father is Jaime Lannister, the queen's brother and the Lord Commander of the Kingsguard. His sole biological grandparents, Tywin and Joanna Lannister, were also first cousins.Joffrey takes after his mother in terms of looks and personality, his blond hair being a subtle clue that he isn't really a Baratheon, who famously always possess black hair even when only one parent is Baratheon. Cersei herself lets it slip to Catelyn Stark that she once had a child with black hair who died prematurely before she had Joffrey.[5] He is usually accompanied by his sworn shield, the formidable Sandor Clegane, better known as the Hound. Even before he ascends to the Iron Throne, Joffrey is spoiled, arrogant, cowardly, childish and sadistic, though he tends to hide them before his ascension. These traits are further exacerbated upon Robert's death and his ascension to the crown."},
                new Characters{Id=5, Name="Robert Baratheon", Family="Baratheon", HouseFK=5, Photo="https://vignette.wikia.nocookie.net/gameofthrones/images/d/d4/RobertBaratheon.jpg/revision/latest?cb=20141119000127", Video="https://youtube.com/watch?v=gi1KhxyjJ18",  Description="King Robert I Baratheon was the ruler of the Seven Kingdoms, formally styled as Robert of the House Baratheon, the First of His Name, King of the Andals and the First Men, Lord of the Seven Kingdoms and Protector of the Realm. Robert, a great warrior and charismatic man in his youth, took the throne through conquest in the war known as Robert's Rebellion, which began when the Prince of Dragonstone, Rhaegar Targaryen, allegedly abducted Robert's betrothed, Lyanna Stark. Killing Rhaegar at the Battle of the Trident, his climactic duel turned the tides of the war in his favor. After the war and following Lyanna's death, Robert married Cersei Lannister to cement an alliance with House Lannister to hold the kingdoms together, but the marriage was loveless. Robert also had two younger brothers, Stannis and Renly. He and Cersei have three children: Joffrey, Myrcella and Tommen.However, unbeknownst to Robert and most of the realm, all three were actually fathered by Cersei's twin brother, Jaime Lannister. On the other hand, Robert had many bastards from other women, including Gendry and Barra."},
                new Characters{Id=6, Name="Daenerys Targaryen", Family="Targaryen", HouseFK=2, Photo="https://www.telegraph.co.uk/content/dam/fashion/2017/07/17/TELEMMGLPICT000060899202_trans_NvBQzQNjv4BqwRbOS5Fov-AuaAhu-Lou8zrDMcQaYb7U2el5Cxl5Klw.jpeg?imwidth=450", Video="https://youtube.com/watch?v=dKElNTMWNZ8",  Description="Daenerys is the only daughter and youngest child of King Aerys II Targaryen, the 'Mad King', and his sister-wife, Rhaella. Her father died during the Sack of King's Landing, before she was even born. The usurper Robert Baratheon installed himself as king, having defeated Aerys in the conquest known as Robert's Rebellion. Her pregnant mother and brother Viserys, fled to the island of Dragonstone, the ancestral home of House Targaryen, to escape Robert. Daenerys's brother Rhaegar Targaryen was killed in the war by Robert. The forces of House Lannister murdered Rhaegar's wife, Elia Martell, and their children, Rhaenys and Aegon, during the Sack of King's Landing. But unbeknownst to Daenerys and the rest of her family, her oldest brother Rhaegar had another son by Lyanna Stark, who died shortly after giving birth to him. In her final moments, she revealed the true name of their son, Aegon Targaryen, to her brother Eddard. To protect his sister's son, Eddard claimed the baby as his illegitimate son and named him Jon, who would grow up to be known as Jon Snow. Eddard raised Jon as his own child in Winterfell and Jon grew up with his maternal side of the family. Jon initially joined the Night's Watch but later became the King in the North. On the night Daenerys was born on Dragonstone, a severe summer storm raged. For this reason, she is sometimes called 'Daenerys Stormborn'. Her mother died soon after she was born, leaving her an orphan. As a baby, she was taken into exile in the Free Cities with her brother, Viserys, by loyal retainers, among them Ser Willem Darry. After years spent fruitlessly trying to raise support to retake the Iron Throne, Viserys and Daenerys were given sanctuary by Magister Illyrio Mopatis in the Free City of Pentos. She dreams of finding a peaceful home and a place to belong. She lives in constant fear of Viserys, who hits her when his temper is risen (in his words, whenever she 'wakes the dragon'). Living under Viserys's domination has left her meek and malleable."},
                new Characters{Id=7, Name="Jon Snow", Family="Targaryen", HouseFK=2, Photo="https://upload.wikimedia.org/wikipedia/pt/6/6f/JonSnow_08.jpg", Video="https://youtube.com/watch?v=zSFABWe9lSg",  Description="Eighteen years before the War of the Five Kings, Rhaegar Targaryen allegedly abducted Lyanna Stark of Winterfell in a scandal that would lead to the outbreak of Robert's Rebellion. Rhaegar would eventually return to fight in the war, but not before leaving Lyanna behind at the Tower of Joy, guarded by Lord Commander Gerold Hightower and Ser Arthur Dayne of the Kingsguard. Lord Eddard Stark, Lyanna's brother, rode to war along with her betrothed, Robert Baratheon, to rescue his sister and avenge the deaths of their father and brother on the orders of Rhaegar's father, Aerys II, the Mad King. Robert would ultimately kill Rhaegar at the Battle of the Trident, effectively ensuring their victory in the war. After the Sack of King's Landing, Ned continued south in search of his sister and ultimately found her at the Tower of Joy in the Red Mountains at the border of Dorne. Ned and his companions engaged in a final fierce melee with the remaining Targaryen Kingsguard, which resulted in the deaths of all combatants save Ned himself and Howland Reed. After defeating the last of the Kingsguard, Ned rushed into the tower to save his sister - only to find Lyanna dying from childbirth, having just given birth to Rhaegar's own son. Desperate to protect the life of her newborn child, a fading Lyanna pleaded with Ned to promise her that he would keep her son safe, and his true heritage hidden from Robert as he had been Rhaegar's most bitter enemy. Furthermore, the boy's existence was a potential threat to Robert's claim to the Iron Throne after the deaths of Rhaegar's other children, Rhaenys and Aegon, by his wife Elia Martell, who also perished, during the Sack of King's Landing. In accordance with her last wish, Ned resolved to pass Lyanna's son off as his own bastard son and raise him in his home castle - a great blow to his honor as he knew that his decision would shame both himself and his lady wife, Catelyn Tully. Ned decided not to use his nephew's birth name, which Lyanna revealed to him in her final moments - apparently because it was a Targaryen-style name which would have given away his real parentage. Instead, he chose to give the baby the name 'Jon' after his great friend and mentor Jon Arryn, Lord of the Vale, whom he loved like a second father. The boy also grew up using the surname 'Snow', as is customary for acknowledged bastards in the North. In truth, however, 'Jon' may not be a bastard at all. Rhaegar apparently had his marriage to Elia annulled and married another, presumably Lyanna. Jon Snow spent the next seventeen years being raised in Winterfell as Lord Eddard's illegitimate son, alongside his trueborn children with his wife. Understandably, Eddard never told anyone, including Catelyn or Jon himself, who his mother was or even if she was still alive. When pressed by King Robert Baratheon, whom he couldn't deny an answer, Ned went as far as to concoct a vague explanation that Jon's mother was some lowborn woman named 'Wylla' that he met during the war. Lady Catelyn's eldest son, Robb, would be acknowledged unquestionably as Eddard's heir, but Jon was otherwise never treated much differently than her younger sons Bran and Rickon. Despite sharing a happy marriage, Jon's presence at Winterfell would serve as a constant source of friction between Eddard and Catelyn. Because Jon was never legitimized, Catelyn was never his 'stepmother' in any sense of the term or had any obligations to him whatsoever. She never mistreated Jon but she was cold towards him and avoided him whenever possible, viewing him only as a living reminder of the one time that Eddard had dishonored her. Catelyn would later confess to her daughter-in-law Talisa about how Jon caught the pox when he was a child, and she stayed with him through the night and prayed to the gods to let him live out of guilt for previously praying for his death, accepting that the boy was not to blame for her husband's sin, though it was still not enough to make her love Jon, something she would eventually come to regret. Due to his bastard status, Jon grew up feeling like an outsider at Winterfell. Although Lord Stark would see that he was well-treated, Jon's attendance at Winterfell's more 'formal' occasions was restricted and he would even be barred from sitting inside at the Lord's table with his family so as not to offend important guests. Otherwise, Jon still lived better than many bastard-born children and was well-raised by Eddard as his own. He was loved by his father and siblings, was never hungry or poor, lived in his father's castle, and had a noble's upbringing. Jon received a highborn education from Maester Luwin and a young lord's martial training from Winterfell's Master-at-Arms, Ser Rodrik Cassel. Of the Stark children, Jon was very close friends with Robb - given that they were roughly the same age, being regular companions in training and riding. He was also close with both Bran and Rickon, as well as having a friendly rival in Lord Eddard's ward, Theon Greyjoy. However, Jon's closest relationship was with Lord Stark's younger daughter, Arya, who, as an adventurous tomboy prone to un-ladylike pursuits, also felt like a social outsider. In contrast, Jon's early relationship with Sansa was unpleasant; very much her mother's daughter, she was aloof and cold to him as well."},
                new Characters{Id=8, Name="Cersei Lannister", Family="Lannister", HouseFK=3, Photo="https://vignette.wikia.nocookie.net/gelofogo/images/1/13/Cersei_Lannister_HBO.jpg/revision/latest?cb=20140603015016&path-prefix=pt-br", Video="https://youtube.com/watch?v=FrJ5LGe-fTc",  Description="Cersei is the only daughter and eldest child of Lord Tywin Lannister and his wife Joanna Lannister, who was also his cousin. Tywin is the head of House Lannister, the richest man in the Seven Kingdoms and Lord Paramount of the Westerlands. The Westerlands are one of the constituent regions of the Seven Kingdoms and House Lannister is one of the Great Houses of the realm. Cersei is the elder twin of Ser Jaime Lannister and the elder sister of Tyrion Lannister. She was raised in privilege in the family seat of Casterly Rock. She is noted for her great beauty. Cersei's mother died when she was four years old, after giving birth to her younger brother Tyrion. Like her father, Cersei has always blamed Tyrion for her mother's death and deeply resents that her mother died so that Tyrion would be brought into the world. As for Cersei's father Tywin, he was constantly away from home during her childhood and teenage years, serving as Hand of the King at the capital, with only infrequent visits back to his seat at Casterly Rock. Coupled with the death of her mother, this meant that Cersei and her two brothers were primarily raised by servants attached to House Lannister. She began an incestuous relationship with Jaime in her youth which has continued despite her marriage. While Cersei has had other partners, Jaime has always kept himself strictly for her. When she was about fifteen, Cersei and her friend Melara visited Maggy, a woods witch and reputed fortune teller dwelling in a hut deep in a forest close to Casterly Rock. Melara was reluctant, but Cersei convinced her to go. After rudely awakening her and insisting on having her future foretold, Maggy tasted a drop of her blood and revealed to Cersei she wouldn't marry �the Prince� but �the King�, and while the king would have twenty children, she would bear only three children who will wear golden crowns as well as golden shrouds. Finally, she revealed to Cersei that although she would indeed be Queen, she would be cast down by another, younger and more beautiful queen. After the end of the civil war which ended the reign of House Targaryen, Cersei was married to King Robert Baratheon, a political marriage Robert agreed to in thanks for her father's last-minute alliance. She was only 19 when she married Robert and became Queen. At first, Cersei was infatuated with the handsome Robert, but their love began to wane when he called her �Lyanna� on their wedding night. She nevertheless bore Robert a son who died shortly after his birth. Cersei was devastated by the loss of her son and refused to have the body taken from her, forcing Robert to hold her while they took her son from her. In time, Cersei's feelings for Robert turned to hatred and she returned to her brother as a result. Her three children, Joffrey, Myrcella and Tommen, are officially Robert's, but in reality are the products of her incestuous relationship with Jaime."},
                new Characters{Id=9, Name="Jaime Lannister", Family="Lannister", HouseFK=3, Photo="https://vignette.wikia.nocookie.net/gameofthrones/images/0/0e/Jaime_Lannister.png/revision/latest?cb=20150911192027&path-prefix=pt-br", Video="https://youtube.com/watch?v=UdxSrjv_5XU",  Description="Ser Jaime Lannister is the eldest son of Tywin, younger twin brother of Cersei, and older brother of Tyrion Lannister. He was involved in an incestuous relationship with Cersei, and unknown to most, he is the biological father of her three children, Joffrey, Myrcella, and Tommen. Jaime previously served in the Kingsguard of Aerys Targaryen, known as the Mad King, before infamously backstabbing him during the Sack of King's Landing, earning Jaime the nickname of the Kingslayer. He continued to serve in the Kingsguard of Robert Baratheon, and as Lord Commander for Robert's alleged sons Joffrey and Tommen. However, a confrontation with the Faith of the Seven led to his dismissal from the sworn order. With Cersei's ascension to the Iron Throne and in light of the death of their uncle, Ser Kevan Lannister, Jaime was appointed as the new commander of the Lannister armies. However, he left his position to honor and help the North face the White Walkers after he learned that Cersei and Euron Greyjoy plot to dishonor the truce between the Iron Throne and the alliance of House Targaryen and House Stark."},
                new Characters{Id=10, Name="Tyrion Lannister", Family="Lannister", HouseFK=3, Photo="https://wallpapershome.com/images/pages/pic_v/15198.jpg", Video="https://www.youtube.com/watch?v=J1TL-EQWtvo",  Description="Lord Tyrion Lannister is the youngest child of Lord Tywin Lannister and younger brother of Cersei and Jaime Lannister. A dwarf, he uses his wit and intellect to overcome the prejudice he faces. His abduction by Catelyn Stark for a crime he did not commit serves as one of the catalysts of the War of the Five Kings. After escaping his captors, Tyrion is appointed by his father as acting Hand of the King to Joffrey Baratheon and successfully defends King's Landing against Stannis Baratheon at the Battle of the Blackwater, after which he is stripped of his power, demoted to Master of Coin and eventually framed for Joffrey's murder. After his champion, Oberyn Martell, dies in Tyrion's trial by combat, Tyrion flees to Essos with help from Jaime and Varys after murdering his father. In the east, he is captured by Jorah Mormont and taken to Daenerys Targaryen in Meereen, whom Varys had intended for Tyrion to meet anyway. Daenerys decides to enlist his help in reclaiming the Iron Throne. For his loyalty and service, Tyrion is named as Hand of the Queen to Daenerys before they set sail for Westeros with her new army and allies, ready to advise her when they reach her ancestral home of Dragonstone, where he acts as her strategist during her invasion of Westeros."},
                new Characters{Id=11, Name="Theon Greyjoy", Family="Greyjoy", HouseFK=4, Photo="https://img00.deviantart.net/f465/i/2015/002/6/6/theon_greyjoy_and_his_daemon_by_lj_todd-d8cdttv.jpg", Video="https://www.youtube.com/watch?v=2IpIB4-ctLA",  Description="Prince Theon Greyjoy is the only living son and heir of Lord Balon Greyjoy of the Iron Islands, and younger brother of Yara Greyjoy. Following his father's failed rebellion against the Iron Throne, Theon is taken as a hostage/ward to Lord Eddard Stark of Winterfell. After Eddard's execution in King's Landing, Theon pledges his loyalty to Eddard's eldest son, Robb Stark, in the subsequent War of the Five Kings, but ultimately betrays Robb and sides with his father in invading the North, which leads to his capture by House Bolton. He is tortured and forced into servitude by Ramsay Snow, who turns him into a broken pet named Reek. Theon, however, redeems himself by helping Ramsay's wife, Sansa Stark, escape from Winterfell and find refuge with her half-brother (revealed to be cousin) Jon Snow, who later retakes Winterfell and defeats Ramsay. Slowly returning to his former self, Theon returns to the Iron Islands, where he learns of his father's death at the hands of his own uncle, Euron Greyjoy. In retaliation, Theon flees with Yara to seek out an alliance with Daenerys Targaryen in Meereen, where they pledge House Greyjoy's forces to her. Despite abandoning Yara during the assault on the Targaryen Fleet, he later appeals to Daenerys's forces to retrieve her from Euron's custody."},
                new Characters{Id=12, Name="Euron Greyjoy", Family="Greyjoy", HouseFK=4, Photo="https://vignette.wikia.nocookie.net/gameofthrones/images/f/fc/Euron-Profile.PNG/revision/latest/scale-to-width-down/318?cb=20170916200257", Video="https://youtube.com/watch?v=dS_QeENwdmw",  Description="King Euron Greyjoy is the brother of Balon Greyjoy, the Lord Reaper of Pyke and later King of the Iron Islands, and Aeron Greyjoy, a Drowned Man. He is also the uncle to Balon's children, Rodrik, Maron, Yara, and Theon Greyjoy. After murdering his brother Balon, Euron takes control of the Salt Throne with the support of many Ironborn and seeks to hunt down Yara and Theon, who oppose Euron and have allied with Daenerys Targaryen. Euron is captain of the longship Silence, the flagship of the Iron Fleet, and wields a two-handed battleaxe in combat. Euron's personal sigil is the standard Greyjoy heraldry of a kraken on black, but the kraken is silver instead of gold with a third red eye inscribed onto its head. Euron is named �Commander of the Lannister Fleet� - although he primarily uses the Iron Fleet as his main ships - after he defeats the allies of Daenerys in Blackwater Bay and delivers Ellaria and Tyene Sand, as a gift to Cersei."},
                new Characters{Id=13, Name="Yara Greyjoy", Family="Greyjoy", HouseFK=4, Photo="https://vignette4.wikia.nocookie.net/gameofthrones/images/2/2e/Yara_Greyjoy_infobox.png/revision/latest?cb=20120621181641", Video="https://youtube.com/watch?v=K_prsoAhcZY",  Description="Yara is the only daughter of Lord Balon and his wife, Lady Alannys of House Harlaw. Balon is the head of House Greyjoy and the Lord of the Iron Islands. The Iron Islands are one of the constituent regions of the Seven Kingdoms, and House Greyjoy is one of the Great Houses of the realm. House Greyjoy rules the region from their seat at Pyke, and Balon also holds the title Lord Reaper of Pyke. Yara was born and raised at Pyke. She was Balon and Alannys's third child after Rodrik and Maron. She also has a younger brother, Theon. Eight years before the start of the series, Balon rose in rebellion against the Iron Throne and was defeated in a bloody war. Balon's two older sons were killed and Theon was taken by Lord Eddard Stark as a hostage for Balon's good behavior and obedience. With Yara as Balon's only remaining child in the Iron Islands, he raised her as a surrogate son, encouraging her to become a reaver in her own right, which is unusual for women in the patriarchal culture of the Ironborn. She is a fierce warrior and commands her own longship, to the disquiet of some of the Ironborn who hold that women should not fight or command men in battle."},

            };
            character.ForEach(cc => context.Characters.AddOrUpdate(c => c.Id, cc));
            context.SaveChanges();
        }
    }
}
