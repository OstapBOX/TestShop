using UnityEngine;
using UnityEngine.Purchasing;
public class IAPShop : MonoBehaviour
{
    private string pinkWings = "totm.pink_wings";
    private string smallDiamondsPack = "totm.small_diamond_pack";
    private string largeDiamondsPack = "totm.large_diamond_pack";
    public GameObject restorePurchasesButton;
 

    private void Awake() {
        DisableRestorePurchaseButton();
    }

    private void Update() {

    }

    public void OnPurchaseComplete(Product product) {
        if(product.definition.id == pinkWings) {
            Debug.Log("Pink wings were bought!");
        }

        if(product.definition.id == smallDiamondsPack) {
            //Give player 5 diamonds
            Debug.Log("Player got 5 diamonds!");
            PlayerData.instance.AddDiamonds(5);
        }

        if(product.definition.id == largeDiamondsPack) {
            //Give player 5 diamonds
            Debug.Log("Player got 25 diamonds!");
            PlayerData.instance.AddDiamonds(25);
        }
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason reason) {
        Debug.Log("Purchase of " + product + " failed due to " + reason);
    }

    public void DisableRestorePurchaseButton() {
        if (Application.platform != RuntimePlatform.IPhonePlayer) {
            restorePurchasesButton.SetActive(false);
        }
    }
}
