using Game.Enemy;
using System;
using UnityEngine;
using UnityEngine.AI;

namespace Game
{
	public sealed class UnitView : AnimationUnitView
	{
		public Action<Node> NodeEntered;

		[SerializeField]
		private RadarView _radar;

		[SerializeField]
		private CircleRadarView _circleRadar;

		[SerializeField]
		private Animator _enemyBehaviour;

		[SerializeField]
		private SkinnedMeshRenderer _meshRenderer;

		[SerializeField]
		private CapsuleCollider _capsuleCollider;

		[SerializeField]
		public NavMeshAgent MeshAgent;

		private bool _isVictim;

		private bool _isVissible;

		public bool IsVictim
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsVissible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsAI
		{
			set
			{
			}
		}

		public float Radius => 0f;

		private void Awake()
		{
		}

		public override void Die()
		{
		}

		public void FireNodeEnter(Node node)
		{
		}

		public void RestartNodes()
		{
		}

		public Collider GetSeenVictim()
		{
			return null;
		}

		public void SetOutline(Material[] materials)
		{
		}
	}
}
