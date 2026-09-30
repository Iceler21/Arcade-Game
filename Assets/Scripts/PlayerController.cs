using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    public Vector2 moveInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    
    void Start()
    {
        moveAction.Enable();
    }

    void Update()
    {
        // Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        moveInput = moveAction.ReadValue<Vector2>();

        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed);
    }
}


/* 

MCU Watch Order

INFINITY SAGA

Phase 1
1. Iron Man (2008)
2. Captain America: The First Avenger (2011) [SKIP AVENGERS TEASER]
3. Iron Man 2 (2010) [SKIP POST-CREDIT SCENE]
4. The Incredible Hulk (2008)
    = One-Shot: The Consultant (2011)
    - Iron Man 2 post-credit scene
    - One=Shot: A Funny Thing Happened on the Way to Thor's Hammer (2011)
5. Thor (2011)
    = Captain America's Avengers Teaser (2011)
6. The Avengers (2012)

Phase 2
1. Captain America: The Winter Soldier (2014)
2. Iron Man 3 (2013)
3. Thor: The Dark World (2013)
4. Guardians of the Galaxy (2014)
5. Avengers: Age of Ultron (2015)

Interlude 1
1. Ant-Man (2015)

Phase 3
1. Captain America: Civil War (2016)
2. Black Panther (2018)
3. Spider-Man: Homecoming (2017)
4. Guardians of the Galaxy Vol. 2 (2017)
5. Ant-Man and the Wasp (2018) [SKIP MID-CREDITS SCENE]
6. Captain Marvel (2019) [SKIP MID AND POST-CREDITS SCENES]
7. Doctor Strange (2016)
8. Thor: Ragnarok (2017)
9. Avengers: Infinity War (2018)
    - Ant-Man and the Wasp post-credit scene
    - Captain Marvel post-credit scene
10. Avengers: Endgame: Encore (2026)

Interlude 2
1. Spider-Man: Far From Home (2019)
2. Venom (2018)

END OF INFINITY SAGA

Interlude

Legacy X-Men
1. X-Men (2000)
2. X2: X-Men United (2003)
3. X-Men: The Last Stand (2006)
4. X-Men Origins: Wolverine (2009)
5. X-Men: First Class (2011)
5. The Wolverine (2013)
6. X-Men: Days of Future Past (2014)
7. X-Men: Apocalypse (2016)
8. X-Men: Dark Phoenix (2019)

MULTIVERSE SAGA

Phase 4a
1. WandaVision (2021)
2. The Falcon and the Winter Soldier (2021)
3. Loki (2021) - Season 1
4. Black Widow (2021)
5. What If...? (2021) - Season 1
6. Shang-Chi and the Legend of the Ten Rings (2021)

Interlude: Spider-Plan

1. Spider-Man (2007)
2. Spider-Man 2 (2004)
3. Spider-Man 3 (2007)
4. The Amazing Spider-Man (2012)
5. The Amazing Spider-Man 2 (2014)
6. Venom: Let There Be Carnage (2021)

Phase 4a (cont.)
1. Spider-Man: No Way Home (2021)
2. Hawkeye (2021)

Fantastic Four Interlude
1. Fantastic Four (2005)
2. Fantastic Four: Rise of the Silver Surfer (2007)
3. Fantastic Four: Fan4stic (2015)

Phase 4a (cont.)
3. Doctor Strange in the Multiverse of Madness (2022)

Phase 4b
1. Venom: The Last Dance (2024)
2. Ms. Marvel (2022)
3. Thor: Love and Thunder (2022)
4. Black Panther: Wakanda Forever (2022)
5. Ant-Man and the Wasp: Quantumania (2023)

Phase 5
1. Loki - Season 2 (2023)
2. Guardians of the Galaxy Vol. 3 (2023)
3. The Marvels (2023)

Interlude - Deadpool & Wolverine's endings
1. Deadpool (2016)
2. Deadpool 2 (2018)
3. Logan (2017)

Phase 5 (cont.)
4. Deadpool and Wolverine (2024)
5. Captain America: Brave New World (2024)
6. The New Avengers (2024)

Phase 6
1. The Fantastic Four: First Steps (2025)
2. Spider-Man: Brand New Day (2026)
3. Avengers: Doomsday (2026)
4. Avengers: Secret Wars (2027)

Phase 7: Rebooted Universe
1. X-Men: Rebirth (2028)
2. Spider-Man: Into the Spider-Verse (2018)
3. Spider-Man: Across the Spider-Verse (2023)
4. Spider-Man: Beyond the Spider-Verse (2028)
5. The New Avengers: Attack of the Sinister Six (2028)

*/