using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Daftcraft
{
    public class SamplePresenter : MonoBehaviour
    {
        [SerializeField]
        private Button _buttonShow;
        [SerializeField]
        private Button _buttonThrow;
        [SerializeField]
        private Button _buttonHide;

        [SerializeField]
        private Animator _animator;

        // Start is called before the first frame update
        void Start()
        {
            _buttonShow.onClick.AddListener( OnClick_Show );
            _buttonHide.onClick.AddListener( OnClick_Hide );
            _buttonThrow.onClick.AddListener( OnClick_Throw );
        }

        private void OnClick_Show()
        {
            _animator?.SetFloat( "speed", 1f );
            _animator?.SetBool( "visible", true );
        }

        private void OnClick_Hide()
        {
            _animator?.SetFloat( "speed", 1f );
            _animator?.SetBool( "visible", false );
            _animator?.Play( "Ofuda_anim_hide" );
        }

        private void OnClick_Throw()
        {
            _animator?.SetFloat( "speed", 5f );
        }
    }
}
