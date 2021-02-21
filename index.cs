//GetComponent(file)
GetComponent<Rigidbody2D>();

//Change velocity
rb.velocity = new Vector2(velocityX, velocityY);

//scale(size) of object
Vector3 playerScale = snake.localScale;

//Follow player movement
public Transform player;
public Vector3 offset;

// Update is called once per frame
void Update()
{
    Debug.Log(player.position);
    transform.position = player.position + offset;
}

//Add Force
rb.AddForce(30 * Time.deltaTime,0,0, ForceMode.VelocityChange);

//Get UI build index
SceneManager.GetActiveScene().buildIndex

//LoadScene
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

//visibility of *GameObject*
completeLevelUI.SetActive(true);

//Time
float time = Time.time;

//GetTouch
var touch = Input.GetTouch(0);

//TouchPosition
var touchPos = touch.position;

//isRight of touching
var isRight = touchPos.x >= Screen.width / 2f;

//GetObject(file) and call class
FindObjectOfType<GameManager>().EndGame();

//QuitApplication
Application.Quit();

//Check Collision with object
void OnCollisionEnter(Collision collisionInfo)
{
    Debug.Log(collisionInfo.collider.name);
    if (collisionInfo.collider.tag == "obstacle")
    {
        movement.enabled = false;
        FindObjectOfType<GameManager>().EndGame();
    }else if(collisionInfo.collider.name == "END"){
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}

//GetPosition of object of specific axis
Text scoreText.text = player.position.z.ToString("0");

//Run code after few sec
using UnityEngine.SceneManagement
IEnumerator RestartLevel(){
    yield return new WaitForSeconds(1f);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
